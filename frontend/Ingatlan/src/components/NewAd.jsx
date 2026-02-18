import { useEffect, useState } from "react";
import "./Hero.css";

function NewAd() {
    const [kategory, setKategory] = useState([]);

    const [form, setForm] = useState({
        kategoria: "",
        leiras: "",
        ar: "",
        tehermentes: false,
        kepUrl: "",
        hirdetesDatuma: new Date().toISOString(),
    });

    useEffect(() => {
        fetch("http://localhost:5158/api/ingatlan/kategoriak")
            .then((res) => {
                if (!res.ok) throw new Error("Hiba lekérdezéskor");
                return res.json();
            })
            .then((data) => {
                console.log("Kategoriak JSON:", data);
                setKategory(Array.isArray(data) ? data : (data.kategoriak ?? []));
            })
            .catch(console.error);
    }, []);

    const handleChange = (e) => {
        const { name, value, type, checked } = e.target;
        setForm((prev) => ({
            ...prev,
            [name]: type === "checkbox" ? checked
                : name === "kategoria" ? (value === "" ? "" : Number(value)) : value
        }));
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        const dto = {
            ...form,
            kategoria: Number(form.kategoria),
            ar: form.ar === "" ? 0 : Number(form.ar),
            hirdetesDatuma: new Date().toISOString()
        };

        console.log("Küldött DTO:", dto);

        fetch("http://localhost:5158/api/ingatlan", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(dto),
        })
            .then(async (res) => {
                if (!res.ok) {
                    const txt = await res.text().catch(() => "");
                    throw new Error("Hiba mentéskor: " + txt);
                }
                return res.json().catch(() => null);
            })
            .then((data) => {
                alert("Sikeres mentés");
                console.log("Mentés válasz:", data);
            })
            .catch(console.error);
    };


    return (
        <form onSubmit={handleSubmit} className="container container-fluid d-flex form">
            <h2>Hirdetés feladása</h2>

            <div>
                <label>Ingatlan kategóriája</label><br />
                <select name="kategoria" value={form.kategoria} onChange={handleChange}>
                    {kategory.map((item, idx) => {
                        const label = item.name ?? item.nev ?? item.Name ?? String(item);
                        const val = item.id ?? label;
                        return (
                            <option key={val ?? idx} value={item.id}>
                                {label}
                            </option>
                        );
                    })}
                </select>
            </div>

            <div>
                <label>Hirdetés Dátuma</label><br />
                <input
                    readOnly
                    name="hirdetesDatuma"
                    value={form.hirdetesDatuma}
                />
            </div>

            <div>
                <label>Ingatlan Leírása</label><br />
                <textarea name="leiras" rows="4" cols="40" value={form.leiras} onChange={handleChange} />
            </div>

            <div className="thermentes">
                <input type="checkbox" name="tehermentes" checked={form.tehermentes} onChange={handleChange} />
                <label>Tehermentes ingatlan</label>
            </div>

            <div>
                <label>Fénykép az ingatlanról</label><br />
                <input name="kepUrl" value={form.kepUrl} onChange={handleChange} />
            </div>

            <button type="submit" className="btn btn-primary">Mentés</button>
        </form>
    );
}

export default NewAd;
