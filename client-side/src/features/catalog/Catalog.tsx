import { Product } from "../../app/models/product"
import ProductList from "./ProductList";
import { useState, useEffect } from "react";


export default function Catalog() {

    const [products, setProducts] = useState<Product[]>([]);

    useEffect(() => {
      fetch('https://localhost:7160/api/products')
        .then(response => response.json())
        .then(data => setProducts(data))
    }, []); //this empty brucket makes the useEffect run once that is very important point!

    return (
        <>
            <ProductList products={products} />
        </>
    )
}


