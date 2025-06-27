function getClubs() {
    return [
        {
            id: 5,
            name: "Nuevo nuevo",
            birthday: "2024-04-11T18:55:45.51",
            city: "Buckridgestad",
            email: "club1@mail.com",
            numberOfPartners: 3871,
            phone: "559-573-4417 x669",
            address: "27956 McKenzie Viaduct",
            stadiumName: null,
            stadium: null
        },
        {
            id: 6,
            name: "nuevo nombre b",
            birthday: "2024-04-11T18:55:45.51",
            city: "Buckridgestad",
            email: "club1@mail.com",
            numberOfPartners: 3871,
            phone: "559-573-4417 x669",
            address: "27956 McKenzie Viaduct",
            stadiumName: "Estado de prueba b",
            stadium: {
                name: "Estado de prueba b",
                capacity: 123,
                clubId: 6,
                aux: null,
                club: null
            }
        },
        {
            id: 7,
            name: "Gottlieb Inc and Sons",
            birthday: "2024-04-11T18:55:45.69",
            city: "North Chad",
            email: "club1@mail.com",
            numberOfPartners: 1230,
            phone: "830.665.2833 x081",
            address: "95326 Gordon Heights",
            stadiumName: null,
            stadium: null
        },
        {
            id: 8,
            name: "Kovacek-Barton",
            birthday: "2024-04-11T18:55:45.7033333",
            city: "East Jaquelineshire",
            email: "club1@mail.com",
            numberOfPartners: 6891,
            phone: "1-068-298-2257",
            address: "76146 Feil Inlet",
            stadiumName: null,
            stadium: null
        },
        {
            id: 9,
            name: "Ratke, Ondricka and Ward",
            birthday: "2024-04-11T18:55:45.7266667",
            city: "Lake Triston",
            email: "club1@mail.com",
            numberOfPartners: 1936,
            phone: "(053)574-8090",
            address: "61292 Jada Square",
            stadiumName: null,
            stadium: null
        },
        {
            id: 10,
            name: "Haley Inc and Sons",
            birthday: "2024-04-11T18:55:45.78",
            city: "Opheliamouth",
            email: "club1@mail.com",
            numberOfPartners: 1037,
            phone: "1-714-261-8564",
            address: "0702 Henry Keys",
            stadiumName: null,
            stadium: null
        }
    ];
}

function renderClubs(clubs) {
    const tbody = document.querySelector("#clubsTable tbody");

    clubs.forEach(club => {
        const row = document.createElement("tr");

        row.innerHTML = `
        <td>${club.id}</td>
        <td>${club.name}</td>
        <td>${club.city}</td>
        <td>${club.email}</td>
        <td>${club.numberOfPartners}</td>
        <td>${club.phone}</td>
        <td>${club.address}</td>
        <td>${club.stadiumName || ''}</td>
        <td>${club.stadium?.capacity ?? ''}</td>
      `;

        tbody.appendChild(row);
    });
}

 window.onload = () => renderClubs(getClubs());
