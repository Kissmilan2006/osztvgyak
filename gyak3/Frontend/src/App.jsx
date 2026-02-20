
import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Home from './components/Home'
import { Route, Routes } from 'react-router-dom'
import Cards from './components/Cards'
import AddCard from './components/AddCard'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <Routes>
        <Route path="/" element={<Home></Home>} />
        <Route path="/Cards" element={<Cards></Cards>} />
        <Route path="/Add" element={<AddCard></AddCard>} />
      </Routes>
    </>
  )
}

export default App
