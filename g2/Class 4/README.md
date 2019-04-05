# PC Configuration app structure <br />

## Folders <br />
* Classes <br />
* Enums <br />
* Interfaces <br />

## Classes <br />
**File**: Configuration.cs <br />
* abstract Item <br />
  string Name <br />
  double Price <br />
  int Quantity <br />
* Part <br />
  double GetPrice() <br />
* Module <br />
  List<Part> parts <br />
  void AddPartToModule(Part part, int quantity) <br />
  double GetPrice()<br />
  void SetDiscount()<br />
  double GetPriceWithDiscount()<br />
* Configuration <br />
  Colors BoxColor <br />
  List<Part> Parts <br />
  List<Module> Modules <br />
  void AddPartToProduct(Part part, int quantity)<br />
  void AddModuleToProduct(Module module, int quantity)<br />
  double GetPrice()<br />
  double GetPriceWithDiscount<br />
  void SetDiscount<br />

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
   void SetDiscount(double discount)<br />
   double GetPriceWithDiscount()<br />

**File:** IPrice.cs <br />
* IPrice <br />
   double GetPrice()<br />
   