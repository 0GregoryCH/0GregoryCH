namespace PedidosEdit {
    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue(
        {
            data:
            {
                Formulario: "#FormEdit",
                Entity: Entity
            },

            methods: {

                PedidosServicio(entity) {
                    console.log(entity);
                    if (entity.IdCodigo == null) {
                        return App.AxiosProvider.PedidosGuardar(entity);

                    } else {
                        return App.AxiosProvider.PedidosEliminar(entity);

                    }
                },

                Save() {

                    if (BValidateData(this.Formulario)) {
                        Loading.fire("Guardando");

                        this.PedidosServicio(this.Entity).then(data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardo correctamente", icon: "success" })
                                    .then(() => window.location.href = "Pedidos/Grid");
                            }
                            else {
                                Toast.fire({ title: data.MsgError, icon: "error" });
                            }


                        }).catch(c => console.log(c));

                    }
                    else {
                        Toast.fire({ title: "Por favor complete los campos requeridos" });

                    }

                }
            },





            mounted() {
                CreateValidator(this.Formulario)

            }
        }

    );

    Formulario.$mount("#AppEdit")

}