import { error } from "console";
import agent from "../../app/api/agent";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { Product } from "../../app/models/product"
import ProductList from "./ProductList";
import { useState, useEffect } from "react";


export default function Catalog() {

    const [products, setProducts] = useState<Product[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
      agent.Catalog.list()
      .then(products => setProducts(products))
      .catch(error => console.log(error))
      .finally(() => setLoading(false))
    }, []); //this empty brucket makes the useEffect run once that is very important point!

    if(loading) return <LoadingComponent message="Loading Products ..."/>

    return (
        <>
            <ProductList products={products} />
        </>
    )
}


