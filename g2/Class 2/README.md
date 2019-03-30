# Homework - Fighter Ground

## Task - Create and implement fighters

* You have 3 given interfaces: **IStreet**, **IBox**, **IMuayThai**. And 1 abstract class: **Fighter**
* First review the code in Program class
* Create 3 classes that inherit from *Fighter*: **StreetFighter**, **ProFighter**, **RockstarFighter**
* StreetFighter should have another property **StreetCredit** and also inherit from: *IStreet*
* ProFighter should have **Expirience** property and inherit from: *IStreet*, *IBox*
* RockstarFighter should have **Reputation** and inherit from: *IStreet*, *IBox*, *IMuayThai*
* StreetCredit, Expirience, Reputation should affect the damage taken on the opponent
* Implement functionalities and logic for each fighter