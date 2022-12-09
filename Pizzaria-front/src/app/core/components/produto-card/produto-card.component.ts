import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Produto } from 'src/app/shared/models/produto.model';
import { CartService } from '../../services/cart.service';
import { ProdutosService } from '../../services/produtos.service';

@Component({
  selector: 'app-produto-card',
  templateUrl: './produto-card.component.html',
  styleUrls: ['./produto-card.component.css'],
})
export class ProdutoCardComponent implements OnInit {
  @Input()
  produto!: Produto;

  constructor(private cartService: CartService) {}

  ngOnInit(): void {}

  AddToCart(produto: Produto) {
    this.cartService.addToCart(produto);
  }
  // AddToCart(produto: Produto) {
  //   this.service.emitirProduto.emit(produto);
  // }
}
