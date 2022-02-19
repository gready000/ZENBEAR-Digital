new Vue({
    el: '#app',
    vuetify: new Vuetify(),
    data() {
        return {
            expanded: [],
            singleExpand: false,
            personaHeaders: [
                {
                    text: 'Nombre',
                    align: 'start',
                    value: 'nombre',
                },
                { text: "Total Días Laborados", value: "totalDiasLaborados" },
                { text: "Total Días Pagados", value: "totalDiasPagados" },
                { text: "Días Restantes", value: "diasrestantes" },
                {
                    text: "",
                    value: "action",
                    sortable: false,
                    align: 'end',
                },
                { text: '', value: 'data-table-expand' },
            ],
            persona: [
                {
                    empleadoId: 1,
                    nombre: 'Juan Perez',
                    totalDiasLaborados: 15,
                    totalDiasPagados: 15,
                    diasrestantes: 0,
                    details: [
                        {
                            diaLaborado: '07/04/2018',
                            diaPagado: "17/09/2018",
                            motivo: "Auditoria",
                        },
                        {
                            diaLaborado: '07/04/2018',
                            diaPagado: "17/09/2018",
                            motivo: "Auditoria",
                        },
                        {
                            diaLaborado: '07/04/2018',
                            diaPagado: "17/09/2018",
                            motivo: "Auditoria",
                        },
                        {
                            diaLaborado: '07/04/2018',
                            diaPagado: "17/09/2018",
                            motivo: "Auditoria",
                        },
                        {
                            diaLaborado: '07/04/2018',
                            diaPagado: "17/09/2018",
                            motivo: "Auditoria",
                        },
                    ],
                },
                {
                    empleadoId: 2,
                    nombre: 'Juan Perez 2',
                    totalDiasLaborados: 15,
                    totalDiasPagados: 10,
                    diasrestantes: 5,
                    details: [
                        {
                            diaLaborado: '08/04/2018',
                            diaPagado: "18/09/2018",
                            motivo: "Auditoria",
                        },
                    ],
                },
                {
                    empleadoId: 3,
                    nombre: 'Juan Perez3',
                    totalDiasLaborados: 15,
                    totalDiasPagados: 4,
                    diasrestantes: 11,
                    details: [
                        {
                            diaLaborado: '09/04/2018',
                            diaPagado: "19/09/2018",
                            motivo: "Auditoria",
                        },
                    ],
                },
            ],
            personaDetailHeaders: [
                { text: "Dia Laborado", value: "diaLaborado" },
                { text: "Dia Pagado", value: "diaPagado" },
                { text: "Motivo", value: "motivo" },
                {
                    text: "",
                    value: "actiondetail",
                    sortable: false,
                    align: 'end',
                },
            ],
        }
    },
})