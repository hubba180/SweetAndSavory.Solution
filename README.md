**<h1 align = "center"> Sweet And Savory Catalogue**


**<h3 align="center">Keep track of your Treats and Flavors!**

<br>

**<h2 align = "center">
  <a href="#✅requirements">Requirements</a> •
  <a href="#💻setup">Setup</a> •
  <a href="#protecting-your-data">Protecting Data</a> •
  <a href="#📫 questions-and-concerns">Q's & C's</a> •
  <a href="#🔧technologies-used">Technologies</a> •
  <a href="#🐛known-bugs">Known Bugs</a> •  
  <a href="#❤️contributors">Contributors</a> •
  <a href="#📘 license">License</a>**

<br>
<h2 align = "center">

**ABOUT**

</p>

_Better description here_


## **✅REQUIREMENTS**

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **🎮User Stories**

| Spec | Input | Output | Status |
| :-------------     | :------------- | :------------- | :------------- | 
| There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on. |  |   |  |
| A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it. |  |   |  |
| The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality. |  |   |  |
|  |  |   |  |

## **💻SETUP**

_NOTICE: The following instructions rely on the intended user to have mySQL Community server and Workbench installed in order to utilize SQL's local server. If mySQL is not installed, users may find a download for the SQL installer [here](https://dev.mysql.com/downloads/file/?id=484914) to install the latest version of Community server and Workbench. Keep track of your local server's password, it will need to be appended to the appsettings.json after "pwd="_. 

copy this url to clone this project to your local system:
```html
https://github.com/hubba180/SweetAndSavory.Solution
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd SweetAndSavory
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```

Next, apply the SQL database to your local workbench with the following command
```js 
dotnet ef database update
```

Finally, you can start the program with this command.
```js 
dotnet run 
```

<!-- ![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/dotnet-readme.gif "How to clone repo")

[w-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png "↓ Windows Compatibility Status ↓"
[l-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/linux-pass-sm.png "↓ Linux Compatibility Status ↓"
[m-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png "↓ macOS (OSX) Compatibility Status ↓" -->
## **PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: commit that .gitignore file (this prevents your sensitive information from being shown to others). **⚠️DO NOT PROCEED UNTIL YOU DO!⚠️**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/entity-readme-image.png "Set up instructions")

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```

#### Step 4: **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

## **🔧Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>


## **🐛Known Bugs**

_**None as of:** 7/31/2020_

<br>


## **❤️The Author**

 [<img src="https://coding-assets.s3-us-west-2.amazonaws.com/img/kyle_hubbard.jpg" width="160px;"/><br /><sub><b>Kyle Hubbard</b></sub>](https://www.linkedin.com/in/k-j-hubbard/)<br />        


<br>

## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Kyle Hubbard, Stickerslug Inc._**