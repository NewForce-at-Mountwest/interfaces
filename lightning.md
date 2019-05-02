## Lightning Exercise 1
Create three more files in the models directory and put a class in each one to represent 3 other flowers. Give each flower a few properties. 

## Lightning Exercise 2
We just got some new requirements from the customer. Refactor your flower classes based on the following information:
Choose the two flowers you want to be in the Mother's Day arrangement and make sure both have a StemLength property. Any flower in this arrangement, even in the future, needs to have a stem length of 5 inches. This means that the StemLength property must exist on those flowers. It can optional on other flowers.
The other two flowers will be in the wedding arrangement. Flowers in the wedding arrangement will always have some white or yellow in them. That means that the Color property must be on flowers for that arrangement. It can be optional on other flowers.

## Lightning Exercise 3
Add the following methods to your `FlowerShop` class:

- A `MakeMothersDayArrangement()` method that returns a list containing a collection of the two flowers you chose for this arrangement. 
- A `MakeWeddingArrangement()` method that returns a list containing a collection of the two flowers you chose for this arrangement. 