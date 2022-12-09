import { Injectable } from '@angular/core';
import { Pedido } from 'src/app/shared/models/pedido.model';
import { PedidoProduto } from 'src/app/shared/models/pedidoProduto.model';
import { Produto } from 'src/app/shared/models/produto.model';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  pedidoProdutos: PedidoProduto[] = [];
  constructor() {}

  addToCart(produto: Produto) {
    const produtoRepetido = this.pedidoProdutos.find(
      (res: PedidoProduto) => res.produtoId == produto.id
    );
    if (produtoRepetido) {
      this.pedidoProdutos.map((res) => {
        if (res.produtoId !== produtoRepetido.produtoId) {
          return;
        }
        res.quantidadeProduto++;
        res.precoPorQuantidade =
          res.produto.precoUnitario * res.quantidadeProduto;
        // this.calculaPrecoTotal();
      });
      return;
    }
    var pedidoProduto = new PedidoProduto();
    pedidoProduto.produtoId = produto.id;
    pedidoProduto.produto = produto;
    pedidoProduto.quantidadeProduto = 1;
    pedidoProduto.precoPorQuantidade =
      pedidoProduto.produto.precoUnitario * pedidoProduto.quantidadeProduto;
    this.pedidoProdutos.push(pedidoProduto);
    // this.calculaPrecoTotal();
  }

  calculaPrecoTotal(listaDeProduto: PedidoProduto[]) {
    let precoTotal = 0;
    listaDeProduto.map((res) => {
      precoTotal += res.precoPorQuantidade;
    });
    return precoTotal;
  }

  getProdutosCart() {
    return this.pedidoProdutos;
  }

  clearCart() {
    this.pedidoProdutos = [];
    // this.precoTotal = 0;
    return this.pedidoProdutos;
  }

  removeProduto(posicaoProduto: number) {
    this.pedidoProdutos.splice(posicaoProduto, 1);
    // this.calculaPrecoTotal();
    return this.pedidoProdutos;
  }
}
