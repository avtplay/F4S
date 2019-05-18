import produitRepository from './produitRepository';

const repositories = {
    produits: produitRepository
}

export default {
    get(name){
        return repositories[name]
    } 
}