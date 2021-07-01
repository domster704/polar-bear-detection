import cv2
import numpy as np

IMG_SIZE = 900
ASPECT_RATIO = 7360 / 4912


def mapSV(value):
    return int(100 * (value / 255))


def write_result_in_file(result):
    with open('ContainsBear.txt', 'w', encoding='utf-8') as f:
        f.write(f'{result}')


file_name = 'Bear.jpg'
orig_image = cv2.imread(file_name, 1)

new_img = cv2.cvtColor(orig_image, cv2.COLOR_BGR2HSV)
h = new_img[:, :, 0]
s = new_img[:, :, 1]
v = new_img[:, :, 2]

v_average = 0
count = 0

for i in range(0, v.shape[0], 115):
    for j in range(0, v.shape[1], 307):
        v_average += v[i][j]
        count += 1

v_average = mapSV(v_average / count) / 50

h_new = np.mod(h - 150, 255).astype(np.uint8)
s_new = np.mod(s + 50, 255).astype(np.uint8)
hsv_new = cv2.merge([h_new, s_new, v])

bgr_new = cv2.cvtColor(hsv_new, cv2.COLOR_HSV2BGR)

dark = (int(96 * v_average), int(58 * v_average), int(93 * v_average))
light = (int(125 * v_average), int(82 * v_average), int(122 * v_average))
mask = cv2.inRange(bgr_new, dark, light)

NEW_SIZE = 1100
maskCopy = cv2.resize(mask.copy(), (int(NEW_SIZE * ASPECT_RATIO), NEW_SIZE))

# Расчёт плотности пикселей в квадоате 10х10 вокруг пикселя
densityListWithCoord = []
density = []
radius = 5
for i in range(maskCopy.shape[0]):
    for j in range(maskCopy.shape[1]):
        if maskCopy[i][j] != 0:
            if i < radius or i > maskCopy.shape[0] - radius:
                pass
            elif j < radius or j > maskCopy.shape[1] - radius:
                pass
            else:
                testImg = maskCopy[i - radius:i + radius, j - radius:j + radius]
                countUnit = 0
                for k in testImg:
                    for l in k:
                        if l != 0:
                            countUnit += 1
                densityListWithCoord.append([countUnit, (i, j)])
                density.append(countUnit)

try:
    maxDensityIndex = density.index(max(density))
except:
    write_result_in_file('false')
    exit()

if 9 < densityListWithCoord[maxDensityIndex][0] < 16:
    lineSize = 15
    position = densityListWithCoord[maxDensityIndex][1]
    y = position[0] - lineSize // 2
    x = position[1] - lineSize // 2
    h = lineSize
    w = lineSize
    orig_image = cv2.resize(orig_image, (int(NEW_SIZE * ASPECT_RATIO), NEW_SIZE))
    cv2.rectangle(orig_image, (x, y), (x + w, y + h), (0, 0, 255), 1)
    cv2.imwrite('BearConverted.JPG', orig_image)
    write_result_in_file('true')
else:
    write_result_in_file('false')