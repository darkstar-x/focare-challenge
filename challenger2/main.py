from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
import time

# Instace Driver
navigator = webdriver.Firefox()
navigator.implicitly_wait(0.5)

# Open URL
navigator.get("https://google.com/")

search_field = navigator.find_element(By.NAME, 'q')

# Search term
search_field.send_keys('Teste')
time.sleep(0.2);

search_field.send_keys(Keys.ENTER)
