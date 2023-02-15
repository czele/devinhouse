/*const obterUsuarios = async (qtd = 4) => {
    const url = `https://randomuser.me/api/?results=4${qtd}`;

    try{
    const response = await fetch(url);
    const data = await response.json();

    return data;
    } catch (error) {
        console.error(error);
    }
}

window.addEventListener('load', async () => {
    //Obtem itens api
    const data = await obterUsuarios();

    const lista = document.getElementById('lista')
    data.results.forEach((usuario) => {
        const item = document.createElement('li');
        const nome = document.createElement('h5');
        const email = document.createElement('p');
        const endereco = document.createElement('p');
        const imagem = document.createElement('img');

        //Desestrutura o objeto criando variáves
        const {street, city, state, country} = usuario.location;
        const {title, first, last} = usuario.name
        
        //Adiciona informações nos itens criados
        nome.innerText = `${title} ${first} ${last}`;
        email.innerText = usuario.email;
        endereco.innerText = `${street.name} ${street.number} ${city} ${state} ${country}`;
        imagem.src = usuario.picture.large; 
        imagem.alt = 'Imagem do usuário'

        //Adiciona os itens dentro do li
        item.appendChild(nome)
        item.appendChild(email)
        item.appendChild(endereco)
        item.appendChild(imagem)

        //Adiciona li dentro da ul
        lista.appendChild(item)
    });
})

criarPessoa()*/

/*const criarHtml = (res) => {
    document.createElement("p");
      p.innerText = res;
      document.body.appendChild(p);
}*/


const criarPessoa = async() => {
    
    const criarSpan = (res) => {    
        const p = document.createElement("p");
        const span = document.getElementById("conteudo");
        p.innerText = res;
        span.appendChild(p);
      }

    const pegarQtd = document.getElementById('form')
    pegarQtd.addEventListener('submit', async (event) => {
        event.preventDefault();
        const qtd = event.target.qtd.value
        
        const BASE_URL = `https://randomuser.me/api/?results=${qtd}`;

        const response = await fetch(BASE_URL)
        const pessoa = await response.json()

       pessoa.results.forEach((x) => {
            const imagem = document.createElement("img")
            const pegarHTML = document.getElementById("conteudo");
            imagem.src = (x.picture.large)
            pegarHTML.appendChild(imagem)

            criarSpan(`Título:${x.name.title} \n Nome: ${x.name.first} \n Sobrenome: ${x.name.last}`)
            criarSpan(`Rua: ${x.location.street.name} \n Número: ${x.location.street.number} \n Estado: ${x.location.state} \n Cidade: ${x.location.city} \n País: ${x.location.country}`)
            
            const risco = document.createElement("hr")
            pegarHTML.appendChild(risco)

        });
        
    })
   
}

criarPessoa();

