# BlackJack Project

Using C#

This project is a console based BlackJack game

## How to initialise
- Download - https://dotnet.microsoft.com/download
- If using VS Code, download the C# extensions 

## Areas of improvements
This is the initial game so it is a very basic version of BlackJack so there are additions that can be added
    - Implementing the full rules of BlackJack, including things such as Pair Splitting etc. 

## Walkthrough
- Initially the game will welcome you and ask you to input your name
- Then the user will be asked to input the stake they would like to bet
- The game will then randomly generate a card number and assign it to the users hand
- The user is then promtped to decide whether to stick or twist
    - If the user twists then they will be assigned another random card number and asked the question again. If the user twists and ends up with a hand greater than 21 then they will go bust and automcatically lose
    - If the user decides to stick then the dealer will then have a turn, the dealer is assigned a card initially. If less than 17 they will be given another card number, if the dealer goes 21 or above then they will bust, if the number is between 17 - 21 then they automatically stick and then the game will check whether the dealer or player has won
- If the player wins then the stake they inputted at the beginning will be doubled.
- The player will be asked if they'd like to play again. If they do then they will be sent back to inputting a stake amount.
