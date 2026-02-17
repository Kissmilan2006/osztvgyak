import { useEffect, useState } from "react";
import DataTable from "react-data-table-component";
import "./Hero.css";

function Offers() {
    const [data, setData] = useState([]);

    useEffect(() => {
        fetch("http://localhost:5158/api/ingatlan")
            .then(res => res.json())
            .then(json => setData(json))
            .catch(err => console.error(err));
    }, []);


    const columns = [
        {
            name: "Kategória",
            selector: row => row.kategoria,
            sortable: true
        },
        {
            name: "Leírás",
            selector: row => row.leiras,
            grow: 2
        },
        {
            name: "Hirdetés dátuma",
            selector: row => row.hirdetesDatuma,
            grow: 2
        }, {
            name: "Tehermentes",
            selector: row => row.tehermentes
        },
        {
            name: "Fénykép",
            selector: row => row.kepUrl,
            sortable: true
        }

    ];

    return (
        <div className="container container-fluid text-center">
            <h2>Ajánlatok</h2>

            <DataTable
                className="table"
                columns={columns}
                data={data}
                pagination
                highlightOnHover
                responsive
            />
        </div>
    );
}

export default Offers;
