import os

import cv2

# if os.path.isfile('BearConverted.JPG'):
#     os.remove('BearConverted.JPG')

img = cv2.imread('Bear.JPG')

img = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

cv2.imwrite('BearConverted.JPG', img)
