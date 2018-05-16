# Automated-User-Updater

##### Web Shop’s User List Export with Selenium POM

This program exports the details of our web shop’s users.
The project uses Selenium.
Our web shop is not synchronized with our newsletter sender web application,
because of this we have to export new users from the admin’s page.
In this page there isn't function like this. Software output is the Export[ActualDate].csv file,
which contains the details of our web shop’s user. 
This file is going to be generated in the Automated-User-Updater\AutomatedUserUpdater\UserInterface\bin\Debug folder.
The program is useless without the file which contains the secret details of 
the webpage.

#

##### Prerequisites

  - Download [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/downloads)
  - Extract the file
  - Put the ChromeDriver into Automated-User-Updater\AutomatedUserUpdater\DriverWrapper\bin\Debug folder.
  - Put the AccessData.xlsx into Automated-User-Updater\AutomatedUserUpdater\DataOperator\bin\Debug folder.
  - Add Selenium.WebDriver and selenium.support to project through nuget.

#
  
##### Author

Dániel Pinczés – Automated-User-Updater - [DanielPinczes](https://github.com/DanielPinczes)