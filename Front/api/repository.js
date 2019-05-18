import axios from "axios"

const baseDomaine = 'https://localhost:44391';
const baseURL = `${baseDomaine}/api`

export default axios.create({
    baseURL
})