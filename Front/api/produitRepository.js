import repository from './repository';

const resource = "/produit";
export default{
    async get (){
        return repository.get(`${resource}`)
    },
    async get (id){
        const data = repository.get(`${resource}/${id}`)
        return data
    },
    async createProduit(item){
        return repository.post(`${resource}`, item).then(response => {return response.data})
    },
    async deleteProduit(id){
        return repository.delete(`${resource}/${id}`).then(response => {return response.data})
    }
}