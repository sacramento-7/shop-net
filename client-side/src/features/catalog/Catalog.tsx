import LoadingComponent from "../../app/layout/LoadingComponent";
import ProductList from "./ProductList";
import { useEffect } from "react";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { fetchProductsAsync, productSelectors } from "./catalogSlice";


export default function Catalog() {
    //const [products, setProducts] = useState<Product[]>([]);
    const products = useAppSelector(productSelectors.selectAll);
    const {productsLoaded, status} = useAppSelector(state => state.catalog);
    const dispatch = useAppDispatch();
    //const [loading, setLoading] = useState(true);

    useEffect(() => {
      if(!productsLoaded) dispatch(fetchProductsAsync());
    }, [productsLoaded, dispatch]); // [] this empty brucket makes the useEffect run once that is very important point!

    if(status.includes('pending')) return <LoadingComponent message="Loading Products ..."/>

    return (
        <>
            <ProductList products={products} />
        </>
    )
}


