# Contact Manager - Console Application :phone:


## Overview
The Contact Manager is a console-based application designed to manage contacts efficiently through basic operations like adding, removing, searching, and viewing contacts. This application serves as a practical tool for organizing contact information directly from the command line.

**Enjoy managing your contacts with ease using our Contact Manager!**

## Features
- **Add Contact**: Enter a new contact's name and phone number. Prevents adding duplicates and ensures fields are not empty.
- **Remove Contact**: Remove a contact by specifying their name. Provides feedback if the contact doesn't exist.
- **Search Contact**: Look up a contact by name to retrieve their phone number.
- **View All Contacts**: Displays a list of all saved contacts. If no contacts exist, it notifies the user appropriately.
- **Colorized Console Output**: Enhances readability and user experience with colored text for different messages and sections.

## Technologies Used
- **C#**: The application is built using C# programming language.
- **Console Application**: Utilizes console-based user interface for interaction.
- **Xunit**: Implements unit tests using Xunit framework for validation.

## Setup
To run the Contact Manager application:
1. Ensure you have .NET Core SDK installed on your machine.
2. Clone this repository to your local machine.
3. Navigate to the project directory.
4. Run `dotnet run` command to start the application.

## Usage
- Upon launching the application, you will be presented with a menu of options to manage your contacts.
- Follow the prompts to add, remove, search, or view contacts.
- Use the numerical keys to select your desired operation and follow the on-screen instructions.

## Unit Tests
The application includes unit tests using Xunit to validate its functionalities:
- **AddCase**: Verifies adding a new contact.
- **IfExist**: Ensures duplicate contacts cannot be added.
- **ViewCase**: Checks if all contacts are correctly displayed.
- **SearchCase**: Tests searching for a specific contact.
- **RemoveCase**: Validates removing a contact from the list.

To run the unit tests:
1. Navigate to the `ContactManagerTests` directory in your terminal.
2. Run `dotnet test` command to execute all unit tests.

**Enjoy managing your contacts with ease using our Contact Manager! Enjoy using our secure app! :smiley:**

