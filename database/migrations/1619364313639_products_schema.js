'use strict'

/** @type {import('@adonisjs/lucid/src/Schema')} */
const Schema = use('Schema')

class ProductsSchema extends Schema {
  up () {
    this.create('produtos', (table) => {
      table.increments('id').primary()
      table.string('nome', 64).notNullable()
      table.integer('categoria_id').references('id').inTable('categorias').notNull()
      table.integer('subcategoria_id').references('id').inTable('subcategorias').notNull()
      table.timestamps()
    })
  }

  down () {
    this.drop('products')
  }
}

module.exports = ProductsSchema
