const user = {
    nombre:'Kevin',
    edad: 39,
    address: {
        calle:'Villa maria',
        ciudad:'Lima',
        pais:'Perú',
    },
    amigos:['Maria','Karina'],
    active: true,
    sendMail: ()=>{
        return 'Enviando correo'
    }
};

console.log(user.sendMail());