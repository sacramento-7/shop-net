import { TableContainer, Paper, Table, TableBody, TableRow, TableCell } from "@mui/material";
import { useStoreContext } from "../../app/context/StoreContext";
//import { useAppSelector } from "../../app/store/configureStore";
//import { currencyFormat } from "../../app/util/util";

// interface Props {
//     subtotal?: number;
// }

export default function BasketSummary() {
    //const { basket } = useAppSelector(state => state.basket);
    //if (subtotal === undefined) 
       // subtotal = basket?.items.reduce((sum, item) => sum + (item.quantity * item.price), 0) ?? 0;
    //const deliveryFee = subtotal > 10000 ? 0 : 500;
    const {basket} = useStoreContext();
    const subtotal = basket?.items.reduce((sum, item)=> sum + (item.quantity * item.price), 0) ?? 0; // ?? means if return null then return 0
    const deliveryFee = subtotal > 100000 ? 0 : 5000;


    return (
        <>
            <TableContainer component={Paper} variant={'outlined'}>
                <Table>
                    <TableBody>
                        <TableRow>
                            <TableCell colSpan={2}>Subtotal</TableCell>
                            <TableCell align="right">{subtotal}T</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Delivery fee*</TableCell>
                            <TableCell align="right">{deliveryFee}T</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell colSpan={2}>Total</TableCell>
                            <TableCell align="right">{subtotal + deliveryFee}T</TableCell>
                        </TableRow>
                        <TableRow>
                            <TableCell>
                                <span style={{ fontStyle: 'italic' }}>*Orders over 100000 Toman qualify for free delivery</span>
                            </TableCell>
                        </TableRow>
                    </TableBody>
                </Table>
            </TableContainer>
        </>
    )
}