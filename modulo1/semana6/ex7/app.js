const BASE_URL = 'https://rickandmortyapi.com/api/character/'

const buscarPersonagens = async () => {
    const response = await fetch (BASE_URL)
    
    const info = await response.json()
    const ids = info.info.count

    //Coloquei o i até 3 pq senão ia fazer 800 requisições na API
    for (let i=1; i <= 3/*ids*/; i++) {
        const listaPersonagens = await fetch (`${BASE_URL}${i}`)
        const responseListaPersonagens = await listaPersonagens.json()
        console.log(`O nome dele é ${responseListaPersonagens.name} e a sua imagem é ${responseListaPersonagens.image}`)
    }
}

buscarPersonagens()