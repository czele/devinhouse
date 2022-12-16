const objUm = { a: 1, b: 2 }
const objDois = { c: 3, d: 4 }

const mesclaObjeto = (objA, objB) => {
    return { ...objA, ...objB }
}

//const mesclaObjeto = (objA, objB) => ({ ...objA, ...objB })

const novoObjeto = (mesclaObjeto(objUm, objDois))

console.log(novoObjeto)