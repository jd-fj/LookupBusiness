# 📍 Local Business Lookup API

### A custom API that lists local restaurants and shops
###### by Taylor Delph

## **Project Description**
A queryable API that lists local restaurants and shops. Search the api by a restaurant or shop name, price point, location, food, or items sold.

### Required for Use
<details>
<summary>Check to see if you have everything you need here</summary>

* A code editor like [VSCode](https://code.visualstudio.com/download)
* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) 
* [MySQL](https://dev.mysql.com/downloads/file/?id=484914)

  * Click the 'No thanks, just start my download' link.
  * Follow along with the installer until you reach the Configuration page. Then select the following options:
  * Use Legacy Password Encryption.
  * Set password to **epicodus** and then click **Finish**.
  * Open the terminal and enter the command `echo 'export PATH="/usr/local/mysql//bin:$PATH"'>>~/.bash_profile`
  * Type `source ~/.bash_profile` in the terminal to verify that MySQL was installed.
  * Enter `mysql -uroot -pepicodus` or `mysql -uroot -p{your_password}` in the terminal to verify the installation. You will know it's installed when you gain access to the `mysql>` command line.


* [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
  * Select the 'No thanks, just start my download' link.
  * Install MySQL Workbench in the Applications folder.
  * Open MySQL Workbench and select the `Local instance 3306` server. You will need to enter the password **epicodus** (or the password you set).
</details>


## 🏗️  Setup and Use via cloning
1. Open your terminal and ensure you are within the directory you'd like the file to be created in.
2. Enter the following command `$ git clone https://github.com/taylulz/LookupBusiness.Solution.git`
3. Once cloned, type into the terminal `$ cd LookupBusiness.Solution/LookupBusiness` to navigate to the root directory.
* Enter `$ dotnet restore`

AppSettings.Json
* Create a file in root directory `appsettings.json`
* Copy and paste the following snippet to the file (if you used your own password, replace 'epicodus' with the one you've set)

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=lookup_business;uid=root;pwd=epicodus;"
  }
}
```
Import Database using Entity Framework Core
* Navigate to LookupBusiness.Solution/LookupBusiness and type `dotnet ef database update` into the terminal. This will update the existing migrations

Launch the API
* Navigate to LookupBusiness.Solution/LookupBusiness and type `dotnet run` into the terminal.

## API Documentation
Explore the API endpoints with Swagger Documentation:
* After launching the API, use a browser to navigate to `http://localhost:5000/swagger/`

### **Endpoints**
Base URL: `http://localhost:5000`

Http Request Structure

```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

### Restaurants
Access local restaurants

```
GET /api/restaurants
POST /api/restaurants
GET /api/restaurants/{id}
PUT /api/restaurants/{id}
DELETE /api/restaurants/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| RestaurantId | int | none | true | return matches by restaurant id.|
| Name | string | none | true | return matches by restaurant name.|
| Offerings | string | none | true | return restaurants by food offered. |
| NearestIntersection | string | none | true | return restaurant's nearest crossroads. |
| Pricing | int | none | true | return restaurants by affordability |

### Example Query
```
http://localhost:5000/api/restaurants/2
```
### Sample JSON Response
```
{
    "restaurantId": 2,
    "name": "Gold Dogs",
    "offerings": "Pristine condition used vinyl store with unbeatable prices",
    "nearestIntersection": "Never St and Going To Happen St",
    "pricing": 1
}
```
...........................................................................................................................................

### Shops
Access local shops

```
GET /api/shops
POST /api/shops
GET /api/shops/{id}
PUT /api/shops/{id}
DELETE /api/shops/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| ShopId | int | none | true | return matches by shop id.|
| Name | string | none | true | return matches by shop name.|
| Offerings | string | none | true | return shop by goods sold. |
| NearestIntersection | string | none | true | return shop's nearest crossroads. |
| Pricing | int | none | true | return shops by affordability |

### Example Query
```
http://localhost:5000/api/shops/2
```
### Sample JSON Response
```
{
    "shopId": 2,
    "name": "Lucca Gifts",
    "offerings": "Offering an array of handmade gifts, paper art, vintage home goods, and unique curios",
    "nearestIntersection": "Ballard Ave NW and Shilshole Ave NW",
    "pricing": 5
}
```

## 🐞 Known Bugs
No known bugs at this time

## Technology Used
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* dotnet script
* Postman
* Swagger
* Swashbuckle

## 📫 Contact
To get in touch, please [contact me here](mailto:taylulzcode@gmail.com)

## 📗 License

MIT License.