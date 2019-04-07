# PC Configuration app structure <br />

## Folders <br />
* Classes <br />
* Enums <br />
* Interfaces <br />

## Classes <br />
**File**: Configuration.cs <br />
* **abstract** ***Item*** <br />
&nbsp; &nbsp; **string** Name <br />
&nbsp; &nbsp; **double** Price <br />
&nbsp; &nbsp; **int** Quantity <br />
* ***Part*** <br />
&nbsp; &nbsp; **double** GetPrice() <br />
* ***Module*** <br />
&nbsp; &nbsp; **List<Part>** parts <br />
&nbsp; &nbsp; **void** AddPartToModule(***Part*** part, ***int*** quantity) <br />
&nbsp; &nbsp; **double** GetPrice()<br />
&nbsp; &nbsp; **void** SetDiscount()<br />
&nbsp; &nbsp; **double** GetPriceWithDiscount()<br />
* ***Configuration*** <br />
&nbsp; &nbsp; **Colors** BoxColor <br />
&nbsp; &nbsp; **List<Part>** Parts <br />
&nbsp; &nbsp; **List<Module>** Modules <br />
&nbsp; &nbsp; **void** AddPartToProduct(***Part*** part, ***int*** quantity)<br />
&nbsp; &nbsp; **void** AddModuleToProduct(***Module*** module, ***int*** quantity)<br />
&nbsp; &nbsp; **double** GetPrice()<br />
&nbsp; &nbsp; **double** GetPriceWithDiscount()<br />
&nbsp; &nbsp; **void** SetDiscount()<br />

**File**: Extensions.cs <br />
* ***Extensions*** <br />
&nbsp; &nbsp; **string** PriceWithCurrency(***string*** currency)<br />

## Enums <br />
**File**: Enums.cs <br />
  * ***Colors*** <br />
&nbsp; &nbsp; *Black* <br />
&nbsp; &nbsp; *Silver* <br />
&nbsp; &nbsp; *Gray* <br />

## Interfaces <br />
**File**: IDiscount.cs <br />
* ***IDiscount*** <br />
&nbsp; &nbsp; **void** SetDiscount(***double*** discount)<br />
&nbsp; &nbsp; **double** GetPriceWithDiscount()<br />

**File:** IPrice.cs <br />
* ***IPrice*** <br />
&nbsp; &nbsp; **double** GetPrice()<br />
   