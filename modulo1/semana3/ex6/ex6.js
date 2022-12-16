let palindromo = (texto) => { 
    const meio = texto.length / 2;
    const fim = texto.length - 1;

    for (let i = 0; i < meio; i++) {
        if (texto[i] !== texto[fim - i]) {
        return false;
    }
    }
     return true;
}

const teste1 = palindromo('osso');
console.log(teste1)

const testenome = palindromo('camila')
console.log(testenome);

const frase = palindromo('socorrame subi em um onibus em marrocos')