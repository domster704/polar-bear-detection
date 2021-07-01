import cv2

img = cv2.imread('Data/Bear.JPG')

img = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

cv2.imread('Data/Bear.JPG')