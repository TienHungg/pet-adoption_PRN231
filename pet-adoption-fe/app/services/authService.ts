import jwt from "jsonwebtoken";
import { TokenDecoded } from "../types/user";
import { Response } from "../types/common";

export async function handleLogin(emailAddress: string, passwordHash: string) {
  try {
    const response = await fetch(
      `${process.env.NEXT_PUBLIC_API_GATEWAY}/api/Authentication/LoginWithEmailAndPasswordJWT`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ emailAddress, passwordHash }),
      }
    );
    // if (!response.ok) {
    //   throw new Error("Login failed");
    // }
    const data = await response.json();
    if (data.success) {
      const decodedToken = jwt.decode(data.token) as TokenDecoded;
      if (!decodedToken) throw new Error("Invalid credentials.");

      const d = {
        username: decodedToken.Email,
        role: decodedToken.Role,
        accessToken: data.token,
        userId: decodedToken.Id,
      };
      return d;
    } else {
      return data;
    }
  } catch (error) {
    console.log(error);
    throw new Error("Invalid credentials");
  }
}

export async function handleRegister(
  isAdmin: boolean = false,
  isStaff: boolean = false,
  emailAddress: string,
  passwordHash: string,
  fullName: string,
  phoneNumber: string
) {
  try {
    const path = isAdmin
      ? "/api/Authentication/RegisterAccountAdminOnAzureDeployment"
      : isStaff
      ? "/api/Authentication/RegisterAccountStaffOnAzureDeployment"
      : "/api/Authentication/RegisterAccountUserOnAzureDeployment";
    const response = await fetch(
      `${process.env.NEXT_PUBLIC_API_GATEWAY}${path}`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          emailAddress,
          passwordHash,
          fullName,
          phoneNumber,
        }),
      }
    );
    console.log(response);

    // if (!response.ok) {
    //   throw new Error("Register failed.");
    // }
    const data = await response.text();
    console.log({ data });

    if (data == "Registered Successfully") return data;
    throw new Error("Register failed! Please try again.");
  } catch (error) {
    console.log(error);
    throw new Error("Register failed. Please try again.");
  }
}

export const verifyUserAccount = async (token: string): Promise<Response> => {
  const response = await fetch(
    `${process.env.NEXT_PUBLIC_API_GATEWAY}/api/User/GetAllUsers/userList/${token}`,
    {
      method: "GET",
      headers: {},
    }
  );
  if (!response.ok) {
    return {
      success: false,
      data: null,
      message: "Fail to verify account",
      error: true,
      errorMessages: "Failed",
    };
  }
  return response.json();
};
