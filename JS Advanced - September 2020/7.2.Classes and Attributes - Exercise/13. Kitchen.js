class Kitchen {

    constructor(budget) {

        this.budget = budget;
        this.menu = [];
        this.productsInStock = [];
        this.actionsHistory = [];

    }

    loadProducts(products) {

        for (let i = 0; i < products.length; i++) {

            let [productName, productQuantity, productPrice] = products[i].split(' ');
            productQuantity = Number(productQuantity);
            productPrice = Number(productPrice);

            if (this.budget - productPrice >= 0) {

                this.budget -= productPrice;

                if (!this.productsInStock[productName]) {

                    this.productsInStock[productName] = 0;
                }

                this.productsInStock[productName] += productQuantity;

                this.actionsHistory.push(`Successfully loaded ${productQuantity} ${productName}`);
            }
            else {

                this.actionsHistory.push(`There was not enough money to load ${productQuantity} ${productName}`);
            }
        }

        return this.actionsHistory.join('\n').trim();
    };

    addToMenu(meal, productsInput, price) {

        if (this.menu[meal]) {

            return `The ${meal} is already in our menu, try something different.`;
        }

        this.menu[meal] = {

            products: productsInput,
            price: Number(price),
        }

        return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`;
    }

    showTheMenu() {

        let result = [];

        for (const product of Object.keys(this.menu)) {

            result.push(`${product} - $ ${this.menu[product].price}`);

        }

        if (result.length === 0) {

            return 'Our menu is not ready yet, please come later...';
        }


        return result.join('\n') + '\n';
    }

    makeTheOrder(meal) {

        if (!this.menu[meal]) {

            return `There is not ${meal} yet in our menu, do you want to order something else?`;
        }

        let products = this.menu[meal].products;

        for (let i = 0; i < products.length; i++) {

            let [product, quantity] = products[i].split(' ');
            
            quantity = Number(quantity);

            if (this.productsInStock[product] - quantity < 0 || !this.productsInStock[product]) {

                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
            }
        }

        for (let i = 0; i < products.length; i++) {

            let [product, quantity] = products[i].split(' ');
            quantity = Number(quantity);

            this.productsInStock[product] -= quantity;
        }

        this.budget += this.menu[meal].price;

        return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`;

    }
}


// let kitchen = new Kitchen(1000);
// console.log(kitchen.loadProducts([
//     'Banana 10 5',
//     'Banana 20 10',
//     'Strawberries 50 30',
//     'Yogurt 10 10',
//     'Yogurt 500 1500',
//     'Honey 5 50'
// ]));

// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

// console.log(kitchen.showTheMenu());

// kitchen.makeTheOrder('frozenYogurt')