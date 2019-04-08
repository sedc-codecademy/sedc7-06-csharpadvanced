# Homework - Cars and a Gas-station
### Task 1
* Create a partial class Car - [*all properties should be in the first part of the class and all methods should be in the second part of the class*] <br />
* The class Car should contain: <br />
Properties: **Brand**: ***string***, **Model**: ***string***, **Color**: ***string***, **Fuel**: ***int***, **HaveKeys**: ***bool***, **IsDrivable**: ***bool*** <br />
Methods: **StartCar()**: ***void***, **StartLights()**: ***void*** <br />
* Implement a logic for both methods based on some of the properties(*you should know which ones*) <br />
* Both methods should print a message accordingly <br />

### Task 2
* Add an extension method on the Car class: **Drive(***string*** place)**: ***void*** 
* Add a static mathod on the Car class: **GetCarStats(***Car*** c)**: ***string*** <br />
* ***Drive*** method should print a message: *...Driving to [place]*. And take some fuel(*random*) <br />
* ***GetCarStats*** method should return a *string* with all stats of the car <br />

### Task 3
* Create a static class GasStation <br />
* GasStation should contain 2 methods: **Refill(***Car*** c)**: ***void***, **PumpUpTires(***Car*** c)**: ***void*** <br />
* ***Refill*** should add a random fuel to the car. And print a message of how much fuel is added <br />
* ***PumpUpTires*** should change the state of the car to drivable if it's not. And print a message that the car now is in good state
