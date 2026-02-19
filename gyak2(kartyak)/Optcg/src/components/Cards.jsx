import { useEffect, useState } from "react"
import { Link } from "react-router-dom";

function Cards() {

    const [data, setData] = useState([])
    useEffect(() => {
        fetch("https://localhost:7141/api/card")
            .then(res => res.json())
            .then(json => { console.log(json); setData(json);})
            .catch(err => console.log(err))
    }, [])
    return (
        <>
            <Link to="/" className="btn btn-primary">Vissza</Link>
            <div className="cotainer container-fluid text-align-center cards">
                {
                    data.map(item => (
                        <div key={item.id} className="card">
                            <img className="card-img-top" src={item.imgUrl} alt="" />
                            <div className="card-body">
                                <h5 className="card-title">{item.name}</h5>
                                <p className="card-text">{item.description}</p>

                            </div>
                        </div>
                    ))
                }

            </div>
        </>
    )
}

export default Cards
