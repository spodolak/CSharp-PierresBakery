# _Word Counter_

#### _Epicodus C# Independent Project_, _Mar. 13, 2020_
#### A web application for a bakery (an exersize utilizing objects in objects)

#### By _**Stephanie Podolak**_

## Description
A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

## Specifications:

| Specification | Example Input | Example Output |
| :-------------:|:-------------:|:-------------:|
| User is greeted by a welcome when first navigating to website | *open home page* | welcome greeting is displayed |
| Allow user to register a new vendor to Pierre's vendor list | User clicks on [*add vendor*] button | *add vendor form page opens* |
| Site intakes vendor details including name and description  | *form filled* [*submit*]  | Data is stored <br> User is routed to home page |
| Site intakes vendor order including title, description, price, and date |  *form filled* [*submit*] | Data is stored <br> User is routed to home page <br> 
| Vendor details and current orders can be individually viewed when user clicks on vendor name | *vendor listing page open* <br> *user clicks on vendor name* | Vendor details and individual vendor orders display on new page |
| Order details can be individually viewed when user clicks on order name | Order name is clicked | *Order details display* |

## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone "https://github.com/spodolak/pierresvendors.git" ``
* ``$ cd PierresVendors.Solution``

_To Run this Console Application, enter the following command in the Terminal:_

* ``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_

### License

*This application is licensed under the MIT license.*

Copyright (c) 2020 **_Stephanie Podolak_**

