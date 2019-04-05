# PC Configuration app structure <br />

## Folders <br />
* Classes <br />
* Enums <br />
* Interfaces <br />

## Classes <br />
**File**: Configuration.cs <br />
* Item <br />
* Part <br />
* Module <br />
AddPartToModule(Part part, int quantity) <br />
  GetPrice()<br />
  SetDiscount()<br />
  GetPriceWithDiscount()<br />
* Configuration <br />
  AddPartToProduct(Part part, int quantity)<br />
  AddModuleToProduct(Module module, int quantity)<br />
  GetPrice()<br />
  GetPriceWithDiscount<br />
  SetDiscount<br />

**File**: Extensions.cs <br />
* Extensions <br />
  PriceWithCurrency(string currency)<br />

## Enums <br />
**File**: Enums.cs <br />
  * Black <br />
  * Silver <br />
  * Gray <br />

## Interfaces <br />
**File**: IDiscount.cs <br />
* IDiscount <br />
   SetDiscount(double discount)<br />
   GetPriceWithDiscount()<br />

**File:** IPrice.cs <br />
* IPrice <br />
   GetPrice()<br />
   