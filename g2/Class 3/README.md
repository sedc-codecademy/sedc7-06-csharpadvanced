# Homework - Cars and a Gas-station
### Task 1
* Create a partial class Car - [*all properties should be in the first part of the class and all methods should be in the second part of the class*]
* The class Car should contain: 
Properties: **Brand**: ***string***, **Model**: ***string***, **Color**: ***string***, **Fuel**: ***int***, **HaveKeys**: ***bool***
Methods: **StartCar()**: ***void***, **StartLights()**: ***void***
* Implement a logic for both methods based on some of the properties(*you should know which ones*)
* Both methods should print a message accordingly

### Task 2
* Add 2 extension methods on the Car class: **Drive(***string*** place)**: ***void***, **GetCarStats()**: ***string***
* ***Drive*** method should print a message: *Driving to [place]*. And take some fuel(*random*)
* ***GetCarStats*** method should return a *string* with all stats of the car

### Task 3
* Create a static class GasStation
* GasStation should contain 1 method: **Refill(Car c)**: ***void***
* ***Refill*** should add a random fuel to the car. And print a message of how much fuel is added
