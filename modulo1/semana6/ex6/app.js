const buscarNome = async (nome) => {
    const url = await fetch (`https://api.agify.io/?country_id=BR&name=${nome}`)
    const response = await url.json()
    console.log(`A idade média de ${nome} é`, response.age)
}
buscarNome('camila')
