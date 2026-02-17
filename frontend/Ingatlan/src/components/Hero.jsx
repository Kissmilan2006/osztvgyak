import { Link } from "react-router-dom";
import "./Hero.css";

function Hero() {
    return (
        <div className="hero container-fluid min-vh-100 d-flex flex-column text-center">
            <div className="hero-top">
                <h1 className="hero-title">Á.L.B Ingatlanügynökség</h1>
            </div>

            <div className="hero-bottom">
                <Link to="/offers" className="hero-btn">
                    Nézze meg kínálatunkat
                </Link>

                <Link to="/newad" className="hero-btn">
                    Hirdessen nálunk!
                </Link>
            </div>
        </div>
    );
}

export default Hero;