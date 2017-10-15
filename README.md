# Console Vending Machine
**Version 1.0**  
A simple vending machine program built from Visual Studio 2015 using C# programming language.

## How it works?
* The items inside the vending machine will show up. The user wil be prompted to enter the code of the desired item:
![pic1](https://user-images.githubusercontent.com/24326950/31590509-8c64880e-b1ce-11e7-9d13-c788a1156e0b.JPG)  
* If the code doesn't match any of the given codes for the items, the program will not proceed until the correct entry has been entered:   
![pic2_validatecode](https://user-images.githubusercontent.com/24326950/31590464-ed2eb426-b1cd-11e7-8ab2-743bfadeaaf6.JPG)  
* The program will prompt "Enter Money" so the user can enter the payment for the item chosen. The program will stop working if the user entered non-monetary characters:  
![pic3_validatemoney](https://user-images.githubusercontent.com/24326950/31590499-63d42796-b1ce-11e7-8f4a-1e843521ddca.JPG)  
* If the money entered is less than the price of the item, the program will not proceed and it will prompt "Money is not enough" and let the user enter money again:  
![pic4_validatemoneygreaterthan](https://user-images.githubusercontent.com/24326950/31590533-f2501b6a-b1ce-11e7-9ace-e4313d34aad6.JPG)  
* If the money entered is greater than the amount of the chosen item, the program will then print an order summary. The program will be terminated:  
![pic5_summary](https://user-images.githubusercontent.com/24326950/31590564-691788dc-b1cf-11e7-9d55-292ac2569d6e.JPG)  

## Coverage

This program covered the following:
* constant variables
* integer, string and double variables
* while loop
* switch statements
* try-catch block


