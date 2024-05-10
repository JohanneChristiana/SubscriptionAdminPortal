# 📄 SubscriptionAdminPortal
C# Programming Language, using Visual Studio. It displays a menu with different options to either create or view client subscriptions.

## Preview
### 📌 SubscriptionProject <br/>
Running the system immediately opens up the menu for Subscription Admin Portal, logging in as a user with Console.WriteLine. The program keeps looping after choosing an option and can only be ended by choosing option 5. Additionally, using DateTime.Now it inputs the current Date and Time registered for the new client.

![SubscriptionAdminPortal_img1](https://github.com/JohanneChristiana/SubscriptionAdminPortal/assets/113961547/f6a08f34-41b0-45a6-bd73-d1ea0511c7c8)

### 📌 Testing <br/>

Entering an option from 1-3 in the CLI results in the following display:

![SubscriptionAdminPortal_img2](https://github.com/JohanneChristiana/SubscriptionAdminPortal/assets/113961547/d37bddcb-28f1-4b99-ba7a-226fe4ad795f)

### 📌 Summary Table <br/>
Viewing all created information by pressing option 4, then afterward loops again and keeps adding to the summary table.

![SubscriptionAdminPortal_img3](https://github.com/JohanneChristiana/SubscriptionAdminPortal/assets/113961547/eaf24982-3654-4279-a2d1-62de7c04100a)

### 📌 Validation <br/>
- When the user doesn't enter any data in the option: "Please enter an option." </br>
- When the user enters invalid data other than the given options: "Please try again, choose from options" </br>
- Choosing option 5 to exit: "Closing Progam..." </br>

- If the user does not enter an organisation name: "Please enter your organisation name." </br>
- If the user does not enter a valid number of users: "Invalid input. Please enter a valid number." </br>
- If the user enters a value outside of 1-100 for the number of users: "Please try again with correct input (Users should range from 1 - 100)." </br>
- If the user doesn't enter Y or N, it results in: "Please try again with correct input (Y or N)." </br>

### 1. Description of the project<br/>
The C# program aims to create a Client class that will store various client details such as the organization's name, amount of users, chosen special offer (Y/N) and its discount = 15%, subscription choice, prices, total amount, and lastly, the date and time. 

### 2. Installation instructions<br/>
To install and run the Subscription Admin Portal, follow these steps:
1. Clone the repository using the following command: git clone https://github.com/JohanneChristiana/SubscriptionAdminPortal.git
2. Open in Visual Studio
3. Build the project
4. Run the application

### 3. Usage instructions<br/>
When running the application, you'll be presented with a menu in the command-line interface (CLI). Follow the prompts to navigate through different options, including creating new subscriptions, viewing existing subscriptions, and exiting the program.

### 4. Description of technologies and tools used.<br/>
The Subscription Admin Portal is developed using the C# programming language within the Visual Studio IDE. No external libraries or imports are used in this project. It only uses directives which are found at the top of the file to bring in namespaces. <br/>
<strong>C#</strong>: The programming language used to develop the Subscription Admin Portal System. [Link](https://visualstudio.microsoft.com/downloads/)<br/>
<strong>Visual Studio</strong>: Used to write the code. [Link](https://visualstudio.microsoft.com/)<br/>

### 5. Link to the UML diagram<br/>
Draw.io used to create UML Diagram: [Link](https://drive.google.com/file/d/1DA3L5n5c0eWlO17bwimm95nQtlDW9yfD/view?usp=sharing)<br/>

![Classes](https://github.com/JohanneChristiana/SubscriptionAdminPortal/assets/113961547/28c3de33-5af3-46b5-8c67-1d8313573512)

### 6. Credits to external sources<br/>
• Stack Overflow contributors: Various solutions and insights were sourced from Stack Overflow discussions, contributing to problem-solving and code implementation.<br/>
• Zhan, D. (2024). NIT3112 Advance Web Application Development. Victoria University.<br/>
