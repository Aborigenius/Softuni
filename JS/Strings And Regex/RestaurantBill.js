function restaurantBill(input) {

    let products = input.filter((e, i) => i % 2 === 0).join(', ');
    let price = input.filter((e, i) => i % 2 === 1).reduce((a, b) => +a + Number(b));

    console.log(`You purchased ${products} for a total sum of ${price}`);
}

restaurantBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80', 'Lasagna', '5.69']);