const buscarPersonagens = async () => {
    const baseUrl = await fetch ('https://rickandmortyapi.com/api/character', {
        method: 'GET',
    })
    
    const info = await baseUrl.json()
  
    console.log(info.count)
    /*for (const i=0; i <= ids; i++) {
        console.log(i)
    }*/ 

}

buscarPersonagens()