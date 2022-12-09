import { Pedido } from './pedido.model';
import { Produto } from './produto.model';

export class PedidoProduto {
  pedidoId?: number;
  produtoId!: number;
  quantidadeProduto!: number;
  precoPorQuantidade!: number;
  produto!: Produto;
  pedido!: Pedido;
}
