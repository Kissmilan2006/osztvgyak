import "bootstrap/dist/css/bootstrap.min.css"
import { useEffect, useState } from "react"
import { Link } from "react-router-dom"
import "./Cards.css"

function Cards() {
    const [data, SetData] = useState([])

    useEffect(() => {
        fetch("http://localhost:5076/api/card")
            .then(res => res.json())
            .then(json => SetData(json),)
            .catch(err => console.log(err))
    }, [])
    console.log(data)
    return (
        <>
            <div className="container container-fluid cards">
                {data.map(item => (
                    <>
                        <div key={item.id} className="card">
                            <img className="card-img-top" src={item.imgUrl} alt="" />
                            <div className="card-body">
                                <h5 className="card-title">{item.name}</h5>
                                <p className="card-text">{item.description}</p>

                            </div>
                        </div>
                    </>
                ))}

            </div>
        </>
    )
}

export default Cards