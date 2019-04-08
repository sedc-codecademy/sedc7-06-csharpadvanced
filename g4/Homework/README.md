# PC PARTS APP ( Homework )
## Summary
A company for PC parts needs an application for ordering and buying PC parts. They decided to have a console application that will be for the clients and that can provide them with ordering and buying products. The company currently sells:
* Parts - Individual Parts 
* Modules - Group of parts that go together
* Configurations - Whole PC Configurations with all the required modules

## Requierments
The company needs these requirements to be implemented in 3 phases with each having a different deadline:
1. Making an order ** 21.04.2019 **
	* The Application should give the client ( user ) the option to order products from the application
	* Parts can be ordered separately, the min quantity of buying being 1 and max being 10
	* Modules can be ordered separately, the min quantity of buying being 1 and max being 5
	* Configurations can be ordered separately but you can only order 1 configuration per order
	* The user can buy multiple products ( mix parts, modules and configuration )
	* The user can have filter options before choosing:
		* All ( shows all products of that type )
		* Price Range ( shows products between a price range. Ex. 100$ - 300$ )
		* Type ( by a product type, depending on the product )
	* When an order is finished, there should be an option to check the order or continue to payment
	* The user can't select options that are not valid such as letters where there is a need for numbers or numbers that are larger than the numbers given
2. Making a payment ** 03.05.2019 **
	* Homework 2
3. Refactoring and extra features ** 13.05.2019 **
	* Homework 3

## Flow
1. A user opens the app and a welcome message is shown. There are also three options :
	* Parts
	* Modules
	* Configurations
2. After choosing an option, filters are shown:
	* All products - ( shows all products )
	* ByPrice - ( requires min and max price and returns product between those numbers )
	* Type - ( requires the user to select a type and then shows all products of that type )
3. The user now sees the products that he chose, filtered by the filter he selected
4. He chooses a number of product and by choosing a number and pressing enter the item is added to his cart
5. The app then gives him a message that a product of type TYPE is added to the cart and asks the user to select one of the following: 
	* Continue Shopping - Gives the same setup that they had ( the product and filter they selected )
	* Choose something else - Gives the option to pick a type of product ( parts , modules, configurations ) and then gives the user a choice to pick a filter again
	* See Cart - Shows all products in the cart so far
	* Continue to Check Out - Continues to payment ( will be implemented in phase 2 )