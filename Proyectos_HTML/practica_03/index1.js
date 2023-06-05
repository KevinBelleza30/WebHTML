const  titulo = Document.creatEliment('H1');
titulo.innerText = "Hola munndo de JS";

const botom = Document.creatEliment('button');
botom.innerText = 'Click';

botom.addEventListenner('Click',() => {
    alert('Hola Mundo de JS');
});
