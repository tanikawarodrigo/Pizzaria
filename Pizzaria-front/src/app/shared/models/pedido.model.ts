import { PedidoProduto } from './pedidoProduto.model';

export class Pedido {
  celular!: number;
  email?: string;
  cpf!: number;
  endereco!: string;
  precoTotal!: number;
  userId?: number;
  tipoPagamentoId?: number;
  statisPedidoId?: number;
  tipoEntregaId?: number;
  statusEntregaId?: number;
  pedidoProduto?: PedidoProduto;
}
