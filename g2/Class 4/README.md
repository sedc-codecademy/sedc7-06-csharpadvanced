# PC Configuration app structure

## Folders
* Classes
* Enums
* Interfaces

## Classes 
**File**: Configuration.cs
* Item
* Part
* Module
AddPartToModule(Part part, int quantity)
  GetPrice()
  SetDiscount()
  GetPriceWithDiscount()
* Configuration
  AddPartToProduct(Part part, int quantity)
  AddModuleToProduct(Module module, int quantity)
  GetPrice()
  GetPriceWithDiscount
  SetDiscount

**File**: Extensions.cs
* Extensions
  PriceWithCurrency(string currency)

## Enums
**File**: Enums.cs
  * Black
  * Silver
  * Gray

## Interfaces
**File**: IDiscount.cs
* IDiscount
   SetDiscount(double discount)
   GetPriceWithDiscount()

**File:** IPrice.cs
* IPrice
   GetPrice()
   