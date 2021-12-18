"use strict";
var PedidosEdit;
(function (PedidosEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity
        },
        methods: {
            PedidosServicio: function (entity) {
                console.log(entity);
                if (entity.IdCodigo == null) {
                    return App.AxiosProvider.PedidosGuardar(entity);
                }
                else {
                    return App.AxiosProvider.PedidosEliminar(entity);
                }
            },
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    this.PedidosServicio(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se guardo correctamente", icon: "success" })
                                .then(function () { return window.location.href = "Pedidos/Grid"; });
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    }).catch(function (c) { return console.log(c); });
                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos" });
                }
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(PedidosEdit || (PedidosEdit = {}));
//# sourceMappingURL=Edit.js.map