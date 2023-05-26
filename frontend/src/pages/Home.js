import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { Box, Button, FormControl, FormLabel, Input } from '@chakra-ui/react';
import api from '../services/api'


const Home = () => {
  const [username, setUsername] = useState('');
  const [user, setUser] = useState(null);

  const handleUsernameChange = (e) => {
    setUsername(e.target.value);
  };

  useEffect(() => {
    if (username) {
      api.get(`/usuarios?username=${username}`)
        .then(response => {
          setUser(response.data.data);
        })
        .catch(error => {
          console.error(error);
        });
    }
  }, [username]);

  return (
    <Box>
      <h1>Home</h1>
      <FormControl id="username" mb={4}>
        <FormLabel>Digite seu nick:</FormLabel>
        <Input type="text" value={username} onChange={handleUsernameChange} />
      </FormControl>
      {user ? (
        <>
                    <p>Usuário encontrado:</p>
                    <p>Nome: {user.username}</p>
        </>
      ) : (
        <>
                <Link to={`/login?username=${username}`}>
                <Button colorScheme="blue" mb={4}>
                    Acessar
                  </Button>
                </Link>
                <Link to="/cadastro">
                  <Button colorScheme="green">
                    Cadastrar
                  </Button>
                </Link>     
          </>   
      )}
    </Box>    
  );
}

export default Home;

