function mostrarMensaje() {

    const formulario = {
        NombreCompleto: document.querySelector("#name").value,
        Correo: document.querySelector("#email").value,
        Telefono: document.querySelector("#phone").value,
        Motivo: document.querySelector("#message").value
    }

    console.log(`NC: ${formulario.NombreCompleto}, C: ${formulario.Correo}, TEL: ${formulario.Telefono}, M: ${formulario.Motivo} `)
    //Mandar datos al controlador
    fetch("/Home/Mensaje", {
        method: "POST",
        headers: { "Content-Type": "application/json; charset=utf-8" },
        body: JSON.stringify(formulario)
    })
    .then(response => response.json()) //Parsear la respuesta
        .then(data => {
            console.log(data);
        const p = document.querySelector(".resultadoFetch");
        p.textContent = data.mensaje;
    })
    .catch(error => {
        console.log(error)
    })
}
 
