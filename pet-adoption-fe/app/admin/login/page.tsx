"use client";

import React, { useState } from "react";
import { useRouter } from "next/navigation";
import { TextField, Button, Container, Typography, Box } from "@mui/material";
import { handleLogin } from "../../services/authService";

const Login = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const router = useRouter();
  /**
 * admin:
    luandktss170438@fpt.edu.vn
    123
  staff: luandokhacthanh@gmail.com 
          123
  user:
    choben13052003@gmail.com
    123456
 */
  const onLogin = async () => {
    setError("");
    try {
      const data = await handleLogin(email, password);
      // console.log(data);
      if (data.success == false) {
        setError(data.message);
      } else {
        if (data.accessToken) {
          localStorage.setItem("accessToken", data.accessToken);
          localStorage.setItem("username", data.username);
          localStorage.setItem("role", data.role);
          localStorage.setItem("userId", data.userId);
          document.cookie = `accessToken=${data.accessToken}; path=/;`;
        }

        if (data.role === "Administrator") {
          router.push("/admin");
        } else if (data.role === "Staff") {
          // alert("Logged in as Staff");
          router.push("/admin");
        } else {
          router.push("/admin");
          // setError("Unknown role");
        }
      }
    } catch (error) {
      setError("Login failed. Please try later.");
      console.log(error);
    }
  };

  return (
    <Box
      sx={{
        backgroundImage: "url(/images/background-login.png)",
        backgroundSize: "cover",
        backgroundPosition: "center",
        minHeight: "100vh",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
      }}
    >
      <Container
        maxWidth="xs"
        sx={{
          backgroundColor: "rgba(255, 255, 255, 0.8)",
          padding: 4,
          borderRadius: 2,
        }}
      >
        <Typography component="h1" variant="h5">
          Login
        </Typography>
        <Box component="form" sx={{ mt: 1 }}>
          <TextField
            margin="normal"
            required
            fullWidth
            id="email"
            label="Email address"
            name="email"
            autoFocus
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            autoComplete="new_input_64"
          />
          <TextField
            margin="normal"
            required
            fullWidth
            name="password"
            label="Password"
            type="password"
            id="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            autoComplete="none"
          />
          {error && <Typography color="error">{error}</Typography>}
          <Button
            fullWidth
            variant="contained"
            sx={{ mt: 3, mb: 2 }}
            onClick={onLogin}
          >
            Sign In
          </Button>
          <p>
            You do not have an account?&nbsp;
            <a href="/admin/register" style={{ color: "#1976d2" }}>
              Register here
            </a>
          </p>
        </Box>
      </Container>
    </Box>
  );
};

export default Login;
