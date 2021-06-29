import cv2
import numpy as np

hsv_max = np.array((255, 255, 255), np.uint8)
hsv_min = np.array((30, 30, 30), np.uint8)

IMG_SIZE = 900
ASPECT_RATIO = 7360 / 4912

if __name__ == '__main__':
	fn = 'data/bear1.jpg'
	orig = cv2.imread(fn, 1)

	img = cv2.cvtColor(orig, cv2.COLOR_BGR2HSV)
	h = img[:, :, 0]
	s = img[:, :, 1]
	v = img[:, :, 2]

	hnew = np.mod(h - 120, 255).astype(np.uint8)
	snew = np.mod(s + 40, 255).astype(np.uint8)
	hsv_new = cv2.merge([hnew, snew, v])

	# def map1(x, min_l=0, max_l=100, min_o=0, max_o=255):
	# 	return (x - min_l) * (max_o - min_o) // (max_l - min_l) + min_o
	#
	# light = (162, 87, 135)
	# dark = (158, 51, 106)
	# mask = cv2.inRange(hsv_new, dark, light)
	#
	# position = np.unravel_index(np.argmax(mask), mask.shape)
	# bgr_new = cv2.cvtColor(hsv_new, cv2.COLOR_HSV2BGR)
	# print(h, s, v)

	# cv2.imshow('ImageWindow', cv2.resize(hsv_new, (int(IMG_SIZE * ASPECT_RATIO), IMG_SIZE)))
	# cv2.waitKey()
	cv2.imwrite('bear1.png', hsv_new)