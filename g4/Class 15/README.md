# Lets build an adventure game
## Adventure Game 🗺
The adventure game is very simple. You have a hero that starts from point 1. There are 30 points that he needs to pass in order to win. On every point an **Event** happens that can change the heroes **Health**, **Armor** or **Food**. If the hero runs out of health the hero dies. The hero can go through the points by rolling a D6 Dice. The rules are:
* The hero has Health, Armor and Food
* A hero starts with 60 Health, 40 Armor and 60 Food
* Hero throws a dice at the start of the game
* After every throw the hero moves that much spaces towards the goal ( 30 or more )
* On every space an event is triggered 
* When event triggers the title is shown, the description and the current health, armor and food after the event took place
* Events are in a folder called Events in the Service project
* Every event changes the hero stats
* You need to check if the hero is dead before and after an event
* After the hero dies or wins you write a message

## Bonus🚩
* Ask the user if they want to start again
* Good event titles are colored with green, Bad with red and Neutral with blue
* While the hero has armor the health from events is reduced by 5
* While the hero has no food, every time they throw a dice they loose 5 health
* If a player enters **aspirine** before hitting enter to roll a dice, give hero 999 health ( Cheat )
