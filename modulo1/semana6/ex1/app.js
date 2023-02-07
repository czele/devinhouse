const sleep = (param) => {
    new Promise ((resolve, reject) => {
        if (sleep) {
            setTimeout(() => {
                resolve(console.log(param))
            }, 3000);
        } else
        setTimeout(() => {
            reject(console.log(param))
        }, 3000);
    })
};

sleep('ola')