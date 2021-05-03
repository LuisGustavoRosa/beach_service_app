'use strict'
const Produtos = use("App/Models/Produtos");
const Produto_User = use ("App/Models/ProdutosUser")


class ProdutosController {

    async store ({ request}) {
        const user_produtos = request.input('produtos');
        const produto_user = await Produto_User.createMany( user_produtos)
        return produto_user;
      }


    async index() {
        const produtos = await Produtos.query()
          .with("categorias")
          .fetch();
        return produtos;
      }
      
    async show({params}){
        return await Produtos.query(params.id)
    }

    async update ({params, request}){
        const Produtos = await Produtos.findOrFail(params.id);
        const dataToUpdate= request.only(['descricao']);
        Produtos.merge(dataToUpdate);
        await Produtos.save();
        return Produtos;
    }

    async destroy({params}){
        const Produtos = await Produtos.findOrFail(params.id);
        await Produtos.delete();
        return {
            message: 'Produto Excluido'
        }
    }
}

module.exports = ProdutosController
