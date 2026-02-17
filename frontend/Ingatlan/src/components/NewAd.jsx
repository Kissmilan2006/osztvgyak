import { useState } from "react";
import "./Hero.css";

function NewAd() {
    const [form, setForm] = useState({
        kategoria: "",
        leiras: "",
        ar: "",
        tehermentes: false
    });

    // mező változás
    const handleChange = (e) => {
        const { name, value, type, checked } = e.target;

        setForm(prev => ({
            ...prev,
            [name]: type === "checkbox" ? checked : value
        }));
    };

    // küldés API-ra
    const handleSubmit = (e) => {
        e.preventDefault();

        fetch("http://localhost:5158/api/ingatlan", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(form)
        })
            .then(res => {
                if (!res.ok) throw new Error("Hiba mentéskor");
                alert("Sikeres mentés");
            })
            .catch(err => console.error(err));
    };

    return (
        <form onSubmit={handleSubmit} className="container container-fluid d-flex form">
            <h2>Hirdetés feladása</h2>

            <div>
                <label>Ingatlan kategóriája</label><br />
                <input
                    name="kategoria"
                    value={form.kategoria}
                    onChange={handleChange}
                />
            </div>
            <div>
                <label>Hirdetés Dátuma</label><br />
                <input
                    readOnly
                    name="hirdetesDatuma"
                    value={new Date().toISOString().split("T")[0].replaceAll("-", ".")}
                    onChange={handleChange}
                />
            </div>
            <div>
                <label>Ingatlan Leírása</label><br />
                <textarea name="leiras" rows="4" cols="40" onChange={handleChange}></textarea>
            </div>
            <div className="thermentes">
                <input type="checkbox" name="thermentes" onChange={handleChange} />
                <label>Tehermentes ingatlan</label>

            </div>
            <div>
                <label>Fénykép az ingatlanról</label><br />
                <input
                    name="kepUrl"
                    value={form.kategoria}
                    onChange={handleChange}
                />
            </div>




            <button type="submit" className="btn btn-primary">Mentés</button>
        </form >
    );
}

export default NewAd;
