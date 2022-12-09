import { Component } from '@angular/core';
import { CartService } from '../../services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
})
export class CartComponent {
  selectedProduto: any;
  selectedProdutoList: any[] = [];
  pedidoProduto: any;
  precoTotal: any;

  constructor(private cartService: CartService) {
    this.selectedProdutoList = cartService.getProdutosCart();
    this.precoTotal = cartService.calculaPrecoTotal(this.selectedProdutoList);
  }

  ngOnInit(): void {
    // this.produtoService.selectedProduto$.subscribe((value) => {
    //   this.selectedProdutoList.push(value);
    // });
  }

  clearCart() {
    this.selectedProdutoList = this.cartService.clearCart();
  }

  removeProduto(index: number) {
    console.log('to sendo clicado');
    this.selectedProdutoList = this.cartService.removeProduto(index);
  }

  calculaTotal() {}
}
